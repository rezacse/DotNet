namespace ProblemSolving.LeetCode.Completed;

public class LRUCache
{
    private readonly int capacity;
    private readonly Dictionary<int, LinkedListNode<(int key, int value)>> map;
    private readonly LinkedList<(int key, int value)> lruList;

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        map = new Dictionary<int, LinkedListNode<(int, int)>>();
        lruList = new LinkedList<(int, int)>();
    }

    public int Get(int key)
    {
        if (!map.ContainsKey(key))
            return -1;

        var node = map[key];

        // Move to most recently used
        lruList.Remove(node);
        lruList.AddLast(node);

        return node.Value.value;
    }

    public void Put(int key, int value)
    {
        if (map.ContainsKey(key))
        {
            var node = map[key];
            node.Value = (key, value);

            // Move to MRU
            lruList.Remove(node);
            lruList.AddLast(node);
        }
        else
        {
            if (map.Count == capacity)
            {
                // Remove LRU (head)
                var lru = lruList.First;

                lruList.RemoveFirst();
                map.Remove(lru.Value.key);
            }

            var newNode = new LinkedListNode<(int, int)>((key, value));
            lruList.AddLast(newNode);
            map[key] = newNode;
        }
    }

}

/**
* Your LRUCache object will be instantiated and called as such:
* LRUCache obj = new LRUCache(capacity);
* int param_1 = obj.Get(key);
* obj.Put(key,value);
*/