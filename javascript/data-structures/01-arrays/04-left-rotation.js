function rotateLeft(d, arr) {
    const newArr = [];
    const n = arr.length;
    for (var i = 0; i < n; i++) {
        const newIndex = (i - d + n) % n;
        newArr[newIndex] = arr[i];
    }
    return newArr;
}