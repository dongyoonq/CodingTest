using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Solved_1157
{
    int n;
    int m;
    int v;
    bool[] visited;
    bool[] chk;
    List<int>[] graph;
    List<int>[] graph2;

    public void Solve()
    {
        int[] nmv = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        n = nmv[0];
        m = nmv[1];
        v = nmv[2];
        visited = new bool[n + 1];
        chk = new bool[n + 1];
        graph = new List<int>[n + 1];
        graph2 = new List<int>[n + 1];
        for (int i = 1; i < graph.Length; i++)
            graph[i] = new List<int>();

        for (int i = 1; i < graph2.Length; i++)
            graph2[i] = new List<int>();

        for (int i = 0; i < m; i++)
        {
            int[] uv = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            graph[uv[0]].Add(uv[1]);
            graph2[uv[0]].Add(uv[1]);
            graph[uv[1]].Add(uv[0]);
            graph2[uv[1]].Add(uv[0]);
        }

        //Console.Write("DFS : ");
        DFS(v);
        Console.WriteLine();
        //Console.Write("BFS : ");
        BFS(v);
    }

    // 깊이 우선 탐색
    void DFS(int n)
    {
        visited[n] = true;
        graph[n].Sort();
        Console.Write($"{n} ");
        for (int i = 0; i < graph[n].Count; i++)
        {
            int value = graph[n][i];
            if (!visited[value])
                DFS(value);
        }
    }

    // 너비 우선 탐색
    void BFS(int n)
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(n);
        chk[n] = true;
        while (q.Count != 0)
        {
            int v = q.Peek();
            graph2[v].Sort();
            Console.Write($"{v} ");
            q.Dequeue();
            for (int i = 0; i < graph2[v].Count; i++)
            {
                int value = graph[v][i];
                if (!chk[value])
                {
                    chk[value] = true;
                    q.Enqueue(value);
                }
            }
        }
    }
}