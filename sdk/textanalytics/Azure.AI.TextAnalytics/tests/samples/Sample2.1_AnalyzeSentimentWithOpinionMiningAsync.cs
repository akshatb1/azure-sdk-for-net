﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Azure.AI.TextAnalytics.Samples
{
    public partial class TextAnalyticsSamples
    {
        [Test]
        public async Task AnalyzeSentimentWithOpinionMiningAsync()
        {
            string endpoint = TestEnvironment.Endpoint;
            string apiKey = TestEnvironment.ApiKey;

            // Instantiate a client that will be used to call the service.
            var client = new TextAnalyticsClient(new Uri(endpoint), new AzureKeyCredential(apiKey), CreateSampleOptions());

            string reviewA = @"The food and service were unacceptable, but the concierge were nice.
                             After talking to them about the quality of the food and the process
                             to get room service they refunded the money we spent at the restaurant
                             and gave us a voucher for nearby restaurants.";

            string reviewB = @"The rooms were beautiful. The AC was good and quiet, which was key for
                            us as outside it was 100F and our baby was getting uncomfortable because of the heat.
                            The breakfast was good too with good options and good servicing times.
                            The thing we didn't like was that the toilet in our bathroom was smelly.
                            It could have been that the toilet was not cleaned before we arrived.
                            Either way it was very uncomfortable.
                            Once we notified the staff, they came and cleaned it and left candles.";

            string reviewC = @"Nice rooms! I had a great unobstructed view of the Microsoft campus
                            but bathrooms were old and the toilet was dirty when we arrived. 
                            It was close to bus stops and groceries stores. If you want to be close to
                            campus I will recommend it, otherwise, might be better to stay in a cleaner one.";

            var documents = new List<string>
            {
                reviewA,
                reviewB,
                reviewC
            };

            var options = new AnalyzeSentimentOptions() { IncludeOpinionMining = true };
            Response<AnalyzeSentimentResultCollection> response = await client.AnalyzeSentimentBatchAsync(documents, options: options);
            AnalyzeSentimentResultCollection reviews = response.Value;

            Dictionary<string, int> complaints = GetComplaint(reviews);

            var negativeAspect = complaints.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            Console.WriteLine($"Alert! major complaint is *{negativeAspect}*");
            Console.WriteLine();
            Console.WriteLine("---All complaints:");
            foreach (KeyValuePair<string, int> complaint in complaints)
            {
                Console.WriteLine($"   {complaint.Key}, {complaint.Value}");
            }
        }

        private Dictionary<string, int> GetComplaint(AnalyzeSentimentResultCollection reviews)
        {
            var complaints = new Dictionary<string, int>();
            foreach (AnalyzeSentimentResult review in reviews)
            {
                foreach (SentenceSentiment sentence in review.DocumentSentiment.Sentences)
                {
                    foreach (SentenceOpinion opinion in sentence.Opinions)
                    {
                        if (opinion.Target.Sentiment == TextSentiment.Negative)
                        {
                            complaints.TryGetValue(opinion.Target.Text, out var value);
                            complaints[opinion.Target.Text] = value + 1;
                        }
                    }
                }
            }
            return complaints;
        }
    }
}
