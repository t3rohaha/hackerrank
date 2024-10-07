const utilities = require('./utilities.js');
const build = utilities.buildSinglyLinkedList;

function findMergeNode(headA, headB) {
    let pointerA = headA;   
    let pointerB = headB;

    while (pointerA) {
        while (pointerB) {
            if (pointerA === pointerB)
                return pointerA.data

            pointerB = pointerB.next;
        }

        pointerA = pointerA.next;
        pointerB = headB;
    }
}

const headA = build([1, 2, 3]);
const headB = build([1]);
const result = findMergeNode(headA, headB);
console.log(result);