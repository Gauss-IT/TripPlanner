using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MultiGraph.DemoConsole
{
    public static class DirectoryTraverserDFS
    {
        public static void TraverseDirectory(string path)
        {
            int count = 0;
            Queue<DirectoryInfo> visitedDirectoryQueue = new Queue<DirectoryInfo>();
            visitedDirectoryQueue.Enqueue(new DirectoryInfo(path));
            while (visitedDirectoryQueue.Any())
            {
                DirectoryInfo currentDirectory = visitedDirectoryQueue.Dequeue();
                count++;
                //Console.WriteLine(currentDirectory.FullName);
                var children = currentDirectory.GetDirectories();
                foreach (var child in children)
                {
                    visitedDirectoryQueue.Enqueue(child);
                }
                if (count % 100 == 0) Console.WriteLine(count);
            }
            Console.WriteLine(count);
        }

        public static void CountFilesAtPath(string path)
        {
            int count = 0;
            Queue<DirectoryInfo> visitedDirectoryQueue = new Queue<DirectoryInfo>();
            visitedDirectoryQueue.Enqueue(new DirectoryInfo(path));
            while (visitedDirectoryQueue.Any())
            {
                DirectoryInfo currentDirectory = visitedDirectoryQueue.Dequeue();
                count += currentDirectory.GetFiles().Length;
                var children = currentDirectory.GetDirectories();
                foreach (var child in children)
                {
                    visitedDirectoryQueue.Enqueue(child);
                }
                if (count % 100 == 0) Console.WriteLine(count);
            }
            Console.WriteLine(count);
        }


    }
}
