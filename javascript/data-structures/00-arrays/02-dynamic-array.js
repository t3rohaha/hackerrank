function dynamicArray(n, queries) {
    const matrix = [];
    for (let i = 0; i < n; i++) {
        matrix.push([]);
    }

    let lastAnswer = 0;
    let answers = [];
    for (let q of queries) {
        let [a, x, y] = [q[0], q[1], q[2]];

        let idx = (x ^ lastAnswer) % n;

        if (a == 1) {
            matrix[idx].push(y);
            continue;
        }

        if (a == 2) {
            lastAnswer = matrix[idx][y % matrix[idx].length];
            answers.push(lastAnswer);
        }
    }

    return answers;
}

const answers = dynamicArray(2, [[1, 0, 5], [1, 1, 7], [1, 0, 3], [2, 1, 0], [2, 1, 1]]);
for (let a of answers) {
    console.log(a);
}
