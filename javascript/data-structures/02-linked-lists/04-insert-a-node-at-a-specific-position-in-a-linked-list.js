const utilities = require('./utilities.js');
const buildSinglyLinkedList = utilities.buildSinglyLinkedList;
const printSinglyLinkedList = utilities.printSinglyLinkedList;

function insertNodeAtPosition(head, data, position) {
    if (position === 0) return { data, next: head };

    let current = head;
    let next = current.next;
    let i = 1;

    while (i != position) {
        current = next;
        next = next.next;
        i++;
    }

    current.next = { data, next };

    return head;
}

let head = buildSinglyLinkedList([20, 6, 2, 19, 7, 4, 15, 9]);
printSinglyLinkedList(head);
head = insertNodeAtPosition(head, 100, 8);
printSinglyLinkedList(head);