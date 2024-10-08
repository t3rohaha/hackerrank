const utilities = require('./utilities.js');
const buildDoublyLinkedList = utilities.buildDoublyLinkedList;
const printLinkedList = utilities.printLinkedList;

function reverse(head) {
    let p = head;   
    while (p) {
        let temp = p.prev;
        p.prev = p.next;
        p.next = temp;
        if (!p.prev) break;
        p = p.prev;
    }
    return p;
}

let head = buildDoublyLinkedList([1, 2, 3, 4]);
head = reverse(head);
printLinkedList(head);