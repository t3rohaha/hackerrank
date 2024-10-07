const utilities = require('./utilities.js');
const build = utilities.buildSinglyLinkedList;
const print = utilities.printSinglyLinkedList;

function removeDuplicates(head) {
    let newHead = { data: null, next: null };
    let tail = newHead; 
    let pointer = head;
    while (pointer) {
        if (pointer.data !== tail.data) {
            tail.next = { data: pointer.data, next: null };
            tail = tail.next;
        }

        pointer = pointer.next;
    }

    return newHead.next;
}

const head = build([1, 2, 2, 3, 3, 3]);
const newHead = removeDuplicates(head);
print(newHead);