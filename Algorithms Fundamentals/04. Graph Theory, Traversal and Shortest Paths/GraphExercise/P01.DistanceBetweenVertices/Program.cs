﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.DistanceBetweenVertices
{
    internal class Program
    {
        private static Dictionary<int, List<int>> graph;
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());

            graph = ReadGraph(n);

            for (int i = 0; i < p; i++)
            {
                var pair = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var source = pair[0];
                var destination = pair[1];

                var steps = GetShortestPath(source, destination);

                Console.WriteLine($"{{{source}, {destination}}} -> {steps}");
            }
        }

        private static int GetShortestPath(int source, int destination)
        {
            var queue = new Queue<int>();
            queue.Enqueue(source);

            var steps = new Dictionary<int, int>();
            steps[source] = 0;

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node == destination)
                {
                    return steps[node];
                }

                foreach (var child in graph[node])
                {
                    if (!steps.ContainsKey(child))
                    {
                        queue.Enqueue(child);
                        steps[child] = steps[node] + 1;
                    }
                }
            }


            return -1;
        }

        private static Dictionary<int, List<int>> ReadGraph(int n)
        {
            var result = new Dictionary<int, List<int>>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);

                var node = int.Parse(line[0]);

                if (line.Length == 1)
                {
                    result[node] = new List<int>();
                }
                else
                {
                    var children = line[1]
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList();

                    result[node] = new List<int>(children);
                }
            }

            return result;
        }
    }
}
