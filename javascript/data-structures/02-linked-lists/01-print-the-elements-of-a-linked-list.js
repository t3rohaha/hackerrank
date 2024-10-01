class SinglyLinkedListNode {
    constructor (data = null, next = null) {
        this.data = data;
        this.next = next;
    }
}

function printLinkedList(head) {
    let pointer = head;
    while (pointer != null) {
        console.log(pointer.data);
        pointer = pointer.next;
    }
}

function seedLinkedList() {
    let head = new SinglyLinkedListNode(-1);
    for (var i = 0; i < 10; i++) {
        var pointer = head;
        while (pointer.next != null)
            pointer = pointer.next;
        pointer.next = new SinglyLinkedListNode(i);
    }
    return head;
}

module.exports = { SinglyLinkedListNode, printLinkedList, seedLinkedList }; 