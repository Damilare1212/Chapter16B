using System;
using System.Collections;
using System.Collections.Generic;

namespace  Chapter_16
{
   public  class DoublyLinkedListNode
    {
        public string Title {get;set;}
        public DoublyLinkedListNode Previous {get;set;}
        public DoublyLinkedListNode Next {get;set;}



        

    }
    public class DoublyLinkedList
    {
        List<DoublyLinkedListNode> List = new List<DoublyLinkedListNode>();


    }
}