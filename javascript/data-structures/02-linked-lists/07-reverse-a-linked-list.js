const utilities = require('./utilities.js');
const buildSinglyLinkedList = utilities.buildSinglyLinkedList;
const printSinglyLinkedList = utilities.printSinglyLinkedList;

function reverse(head) {
    if (head == null) return;

    const nodes = [];
    let pointer = head;
    while (pointer != null) {
        nodes.push(pointer);
        pointer = pointer.next;
    }

    for (let i = nodes.length - 1; i > 0; i--)
        nodes[i].next = nodes[i-1];

    nodes[0].next = null;

    return nodes[nodes.length - 1];
}

let head = buildSinglyLinkedList([1, 2, 3]);
printSinglyLinkedList(head);
head = reverse(head);
printSinglyLinkedList(head);
