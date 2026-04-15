namespace ProblemSolving.LeetCode.Completed;

public class LFUCache
{

    private class Node(int key, int value)
    {
        public int Key { get; } = key;
        public int Value { get; set; } = value;
        public int Freq { get; set; } = 1;
    }


    Dictionary<int, Node> cache;
    Dictionary<int, LinkedList<Node>> freqList;
    Dictionary<int, LinkedListNode<Node>> refList;

    int capacity;
    int minFreq;

    public LFUCache(int capacity)
    {
        this.capacity = capacity;
        this.minFreq = 0;
        cache = [];
        freqList = [];
        refList = [];
    }

    public int Get(int key)
    {
        if (!cache.ContainsKey(key)) return -1;

        var node = cache[key];

        Update(node);

        return node.Value;
    }

    public void Put(int key, int value)
    {
        if (capacity == 0) return;

        if (cache.ContainsKey(key))
        {
            var node = cache[key];
            node.Value = value;
            Update(node);
            return;
        }

        if (cache.Count == capacity)
        {
            var fList = freqList[minFreq];
            var rNode = fList.First!.Value;

            fList.RemoveFirst();
            
            cache.Remove(rNode!.Key);
            refList.Remove(rNode.Key);
        }

        var newNode = new Node(key, value);
        cache.Add(key, newNode);

        if (!freqList.ContainsKey(1))
            freqList[1] = new LinkedList<Node>();

        var lastNode = freqList[1].AddLast(newNode);
        refList.Add(key, lastNode);
        minFreq = 1;
    }

    private void Update(Node node)
    {
        freqList[node.Freq].Remove(refList[node.Key]);

        if (freqList[node.Freq].Count == 0 && node.Freq == minFreq)
            minFreq++;

        node.Freq++;

        if (!freqList.ContainsKey(node.Freq))
            freqList[node.Freq] = new LinkedList<Node>();

        var nodeRef = freqList[node.Freq].AddLast(node);
        refList[node.Key] = nodeRef;
    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */