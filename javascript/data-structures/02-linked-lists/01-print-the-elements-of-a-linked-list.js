const utilities = require('./utilities.js');
const buildSinglyLinkedList = utilities.buildSinglyLinkedList;

function printLinkedList(head) {
    let pointer = head;
    while (pointer != null) {
        console.log(pointer.data);
        pointer = pointer.next;
    }
}

let head = buildSinglyLinkedList([20, 6, 2, 19, 7, 4, 15, 9]);
printLinkedList(head);