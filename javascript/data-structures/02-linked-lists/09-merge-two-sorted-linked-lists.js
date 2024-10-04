const utilities = require('./utilities.js');
const build = utilities.buildSinglyLinkedList;
const print = utilities.printSinglyLinkedList;

function mergeLists(head1, head2) {
    let newNode = {};
    let tail = newNode;
    let pointer1 = head1;
    let pointer2 = head2;

    while (pointer1 || pointer2) {
        if (!pointer1) {
            tail.next = pointer2;
            break;
        }
        
        if (!pointer2) {
            tail.next = pointer1;
            break;
        }

        if (pointer1.data <= pointer2.data) {
            tail.next = pointer1;
            tail = tail.next;
            pointer1 = pointer1.next;
        } else {
            tail.next = pointer2;
            tail = tail.next;
            pointer2 = pointer2.next;
        }
    }

    return newNode.next;
}

let head1 = build([1, 3, 7]);
let head2 = build([1, 2]);
let mergeHead = mergeLists(head1, head2);
print(mergeHead);
