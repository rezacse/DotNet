#include <iostream>
#include <cstdlib>
using namespace std;

struct Node {
    int data;
    Node *next;
};

class LinkedList {
    private:
        Node *tail;
        Node* createNewNode(int v)
        {
            Node *node = new Node;
            node->data = v;
            node->next = NULL;

            return node;
        }
    public:
        Node *head;
        LinkedList()
        {
            head = NULL;
            tail = NULL;
        }


        void addItem(int v)
        {
            Node *node = createNewNode(v);
            if(head==NULL)
            {
                head = node;
                tail = node;
            }
            else {
                tail->next = node;
                tail = node;
            }
        }

        void printList(Node *h)
        {
            Node *current = new Node;
            current = h;
            while(current!=NULL)
            {
                cout<<current->data<<" ";
                current = current->next;
            }
        }

        int middleElement(Node *h)
        {
            if(h==NULL)
                return -1;

            Node *current = new Node;
            Node *next = new Node;
            current = h;
            next = h;
            while(next != NULL && next->next != NULL)
            {
                current = current->next;
                next = next->next->next;
            }

            return current->data;

            // int middle = count/2 + 1;
            // current = h;
            // count = 0;
            // while(current != NULL)
            // {
            //     count++;
            //     if(count == middle)
            //         return current->data;
                
            //     current = current->next;
            // }
        }
};

void LinkedListDemo()
{
    LinkedList list;
    for(int i=0;i<n;i++)
    {
        cin>>t; 
        list.addItem(t);           
    }

    cout<<list.middleElement(list.head)<<endl;
}