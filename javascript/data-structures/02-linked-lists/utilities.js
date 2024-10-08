class SinglyLinkedListNode {
    constructor(data = null, next = null) {
        this.data = data;
        this.next = next;
    }
}

class DoublyLinkedListNode {
    constructor(data = null, next = null, prev = null) {
        this.data = data;
        this.next = next;
        this.prev = prev;
    }
}

function buildDoublyLinkedList(arr) {
    let head = new DoublyLinkedListNode(arr[0]);
    let pointer = head;
    for (var i = 1; i < arr.length; i++) {
        pointer.next = new DoublyLinkedListNode(arr[i], null, pointer)
        pointer = pointer.next;
    }
    return head;
}

function buildSinglyLinkedList(arr) {
    let head = new SinglyLinkedListNode(arr[0]);
    let pointer = head;
    for (var i = 1; i < arr.length; i++) {
        pointer.next = new SinglyLinkedListNode(arr[i]);
        pointer = pointer.next;
    }
    return head;
}

function printLinkedList(head) {
    let output = [];
    let pointer = head;
    while (pointer != null) {
        output.push(pointer.data);
        pointer = pointer.next;
    }
    console.log(output.join(', '));
}

module.exports = {
    SinglyLinkedListNode,
    buildSinglyLinkedList,
    buildDoublyLinkedList,
    printLinkedList
};