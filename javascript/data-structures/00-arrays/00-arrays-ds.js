function reverseArray(arr) {
    const n = arr.length;
    for (let i = 0; i < n / 2; i++) {
        const temp = arr[i];
        arr[i] = arr[n - i - 1];
        arr[n - i - 1] = temp;
    }
    return arr;
}

const arr = reverseArray([1, 2, 3, 4, 5]);

console.log(arr.join(' '));