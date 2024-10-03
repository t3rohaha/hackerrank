const utilities = require('./utilities.js');
const printSinglyLinkedList = utilities.printSinglyLinkedList;

function insertNodeAtHead(head, data) {
    return { data, next: head };
}

let head = null;
head = insertNodeAtHead(head, 10);
head = insertNodeAtHead(head, 11);
head = insertNodeAtHead(head, 12);
printSinglyLinkedList(head);