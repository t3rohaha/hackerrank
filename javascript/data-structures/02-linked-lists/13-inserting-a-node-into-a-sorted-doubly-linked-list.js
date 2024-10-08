const utilities = require('./utilities.js');
const buildDoublyLinkedList = utilities.buildDoublyLinkedList;
const printLinkedList = utilities.printLinkedList;

function sortedInsert(head, data) {
    let pointer = head;

    while (pointer) {
        if (data <= pointer.data) {
            if (!pointer.prev)  {
                head = {data: data, prev: null, next: pointer};
                pointer.prev = head;
            } else {
                const newNode = {data: data, prev: pointer.prev, next: pointer};
                pointer.prev.next = newNode;
                pointer.prev = newNode;
            }

            break;
        }

        if (!pointer.next) {
            const newNode = {data: data, prev: pointer, next: null};
            pointer.next = newNode;
            break;
        }

        pointer = pointer.next;
    }

    return head;
}

let head = buildDoublyLinkedList([5]);
printLinkedList(head);
head = sortedInsert(head, 1);
printLinkedList(head);