const utilities = require('./utilities.js');
const buildSinglyLinkedList = utilities.buildSinglyLinkedList;

function reversePrint(head) {
    if (head == null) return;

    let nodeValues = [];
    let pointer = head;
    while (pointer != null) {
        nodeValues.push(pointer.data);
        pointer = pointer.next;
    }

    for (let i = nodeValues.length - 1; i >= 0; i--)
        console.log(nodeValues[i]);
}

const head = buildSinglyLinkedList([1, 2, 3]);
reversePrint(head);