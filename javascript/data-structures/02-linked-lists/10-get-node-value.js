const utilities = require('./utilities.js');
const build = utilities.buildSinglyLinkedList;

function getNode(head, i) {
    const nodeValues = [];
    let pointer = head;
    while (pointer) {
        nodeValues.push(pointer.data);
        pointer = pointer.next;
    }
    return nodeValues[nodeValues.length - 1 - i];
}

const head = build([3, 2, 1, 0]);
console.log(getNode(head, 3));