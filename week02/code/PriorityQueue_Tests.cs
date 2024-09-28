using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a priority queue and enqueue three items with different priorities.
    // Expected Result: The items should be added in the order they were enqueued: 
    // FirstItem (Pri:1), SecondItem (Pri:2), ThirdItem (Pri:3).
    // Defect(s) Found: None
    public void Enqueue_AddsItemToBackOfQueue()
    {
        var queue = new PriorityQueue();

        queue.Enqueue("FirstItem", 1);
        queue.Enqueue("SecondItem", 2);
        queue.Enqueue("ThirdItem", 3);

        var expectedString = "[FirstItem (Pri:1), SecondItem (Pri:2), ThirdItem (Pri:3)]";
        Assert.AreEqual(expectedString, queue.ToString(), "Items should be added to the back of the queue in the order they were enqueued.");
    }
    
    [TestMethod]
    // Scenario: Enqueue items with varying priorities into the priority queue.
    // Expected Result: When dequeuing, the highest priority item should be returned first, 
    // which is "High Priority Item".
    // Defect(s) Found: The Dequeue method does not correctly respect item priorities.
    public void Dequeue_RemovesItemsInPriorityOrder()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low Priority Item", 1);    
        priorityQueue.Enqueue("Medium Priority Item", 5); 
        priorityQueue.Enqueue("High Priority Item", 10);  
    
        var highestPriorityItem = priorityQueue.Dequeue();
    
        Assert.AreEqual("High Priority Item", highestPriorityItem, "The highest priority item should be returned first.");
    }

    [TestMethod]
    // Scenario: Enqueue three items with the same priority and dequeue them in order.
    // Expected Result: The items should be dequeued in the order they were enqueued:
    // "First Item", "Second Item", "Third Item".
    // Defect(s) Found: The Dequeue method fails to remove items from the queue, causing repeated returns of the same item.
    public void Dequeue_RemovesEqualPriorityItemsInOrder()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("FirstItem", 5);
        queue.Enqueue("SecondItem", 5);
        queue.Enqueue("ThirdItem", 5);

        Assert.AreEqual("FirstItem", queue.Dequeue(), "The first item with equal priority should be dequeued first.");
        Assert.AreEqual("SecondItem", queue.Dequeue(), "The second item with equal priority should be dequeued second.");
        Assert.AreEqual("ThirdItem", queue.Dequeue(), "The third item with equal priority should be dequeued third.");
    }
}