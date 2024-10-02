const helper = require('./01-print-the-elements-of-a-linked-list.js');
const SinglyLinkedListNode = helper.SinglyLinkedListNode;

function insertNodeAtHead(data, head) {
    let newHead = new SinglyLinkedListNode();
    newHead.data = data;
    newHead.next = head;
    return newHead;
}
