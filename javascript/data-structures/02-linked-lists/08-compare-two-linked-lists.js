const utilities = require('./utilities.js');
const buildSinglyLinkedList = utilities.buildSinglyLinkedList;

function compare(head1, head2) {
    let pointer1 = head1;
    let pointer2 = head2;

    while (pointer1 != null && pointer2 != null) {
        if (pointer1.data !== pointer2.data)
            return 0;

        pointer1 = pointer1.next;
        pointer2 = pointer2.next;
    }

    if (pointer1 != null || pointer2 != null)
        return 0;

    return 1;
}

let head1 = buildSinglyLinkedList([1, 2, 3]);
let head2 = buildSinglyLinkedList([1, 2, 3, 4]);

console.log(compare(head1, head2));