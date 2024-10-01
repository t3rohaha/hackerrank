const helper = require('./01-print-the-elements-of-a-linked-list.js');
const seedLinkedList = helper.seedLinkedList;
const printLinkedList = helper.printLinkedList;
const SinglyLinkedListNode = helper.SinglyLinkedListNode;

function insertNodeAtTail(head, data) {
    const newNode = new SinglyLinkedListNode(data);
    if (head == null)
        return newNode;

    let pointer = head;
    while (pointer.next != null)
        pointer = pointer.next;
    pointer.next = newNode;
    return head;
}

let head = seedLinkedList();
insertNodeAtTail(head, 10);
insertNodeAtTail(head, 11);
printLinkedList(head);