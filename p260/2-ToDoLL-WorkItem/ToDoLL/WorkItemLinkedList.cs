﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLL
{
    class WorkItemLinkedList
    {
        //*********************************************************************************************
        // define our Nested Class, a class that defines the objects that are in the linked lists
        protected class LinkedListNode
        {
            public int node_data;  // Property holds the "data", this could be a complex object, like a Customer object
            public LinkedListNode node_next_pointer;  // Property holds the "pointer" (actually a node with a pointer in it)  to the next node in the list
            public WorkItem TheWorkItem { get; set; }

            // constructor: call it to create and set value of data, note the node_next_pointer property is set to null by default      
            public LinkedListNode(int value, WorkItem pWhatWhy)
            {
                node_data = value;
                TheWorkItem = pWhatWhy;
            }
        }
            //*********************************************************************************************

            // now define the IntLinkedList Class
            // the only data item the class has is the pointer (actually a node with a pointer in it) to the first item in the list 
            protected LinkedListNode frontOfList; // No constructor, but an undefined object has the value null; which is our flag that the list is empty

            //*********************************************************************************************

            // Method to add a node to the front of the list:
            public void InsertAtFront(int value, WorkItem pWorkItem)
            {
                LinkedListNode newNode = new LinkedListNode(value, pWorkItem);  // create a new node
                newNode.node_next_pointer = frontOfList; // make this new first node point to what was just the first node;
                                                         // if the List had been empty, then we just made the newNode point to "null", which says there is no 2nd node.
                frontOfList = newNode; // change the "reference" to front of list to point to this new one, which itself now points to the prior front of list
                                       // we are dealing with this frontOfList because this method specifically says to add to the front.  Later we will insert into other places.
            }
            //*********************************************************************************************
        
            // Method to remove the node from the front of the list
            public WorkItem RemoveFromFront()  // returns the "value" that the list object stores, in this case, an int
            {
                WorkItem returnVal;
                if (frontOfList == null)
                {
                    throw new IndexOutOfRangeException("list is empty");
                }
                else
                {
                    returnVal = frontOfList.TheWorkItem; // get the data from the node at the front of the list
                    frontOfList = frontOfList.node_next_pointer;  // copy the front of list's node's pointer to the next node, into the front of List
                    // if there was not another node, we just copied a null into the pointer, which says the list is now empty
                }
                return returnVal;
            }




        }
}