const utilities = require('./utilities.js');
const buildSinglyLinkedList = utilities.buildSinglyLinkedList;
const printSinglyLinkedList = utilities.printSinglyLinkedList;

function deleteNode(head, position) {
    if (position == 0) return head.next;

    let pointer = head;
    for (var i = 0; i < position - 1; i++) {
        pointer = pointer.next;
    }
    pointer.next = pointer.next.next;
    return head;
}

let head = buildSinglyLinkedList([20, 6, 2, 19, 7, 4, 15, 9]);
printSinglyLinkedList(head);
head = deleteNode(head, 7);
printSinglyLinkedList(head);