const utilities = require('./utilities.js');
const printSinglyLinkedList = utilities.printSinglyLinkedList;

function insertNodeAtTail(head, data) {
    const newNode = { data };

    if (head == null) return newNode;

    let pointer = head;
    while (pointer.next != null)
        pointer = pointer.next;
    pointer.next = newNode;
    return head;
}

let head = null;
head = insertNodeAtTail(head, 10);
head = insertNodeAtTail(head, 11);
head = insertNodeAtTail(head, 12);
printSinglyLinkedList(head);