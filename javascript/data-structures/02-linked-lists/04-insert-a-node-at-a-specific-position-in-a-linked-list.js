const helper = require('./01-print-the-elements-of-a-linked-list.js');
const SinglyLinkedListNode = helper.SinglyLinkedListNode;

function insertNodeAtPosition(llist, data, position) {
    if (position === 0) {
        const newNode = new SinglyLinkedListNode();
        newNode.data = data;
        newNode.next = llist;
        return newNode;
    }

    let current = llist;
    let next = current.next;
    let i = 1;

    while (i != position) {
        current = next;
        next = next.next;
        i++;
    }

    const newNode = new SinglyLinkedListNode();
    newNode.data = data;
    newNode.next = next;
    current.next = newNode;
    return llist;
}