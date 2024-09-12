function hourglassSum(matrix) {
    let maxSum = Number.MIN_SAFE_INTEGER;

    // matrix is always 6x6, hourglass 3x3
    for (let r = 0; r < 4; r++) {
        for (let c = 0; c < 4; c++) {
            const row1 = matrix[r][c] + matrix[r][c+1] + matrix[r][c+2];
            const row2 = matrix[r+1][c+1];
            const row3 = matrix[r+2][c] + matrix[r+2][c+1] + matrix[r+2][c+2];
            const sum = row1 + row2 + row3;

            if (sum > maxSum) {
                maxSum = sum;
            }
        }
    }

    return maxSum;
}

const maxSum1 = hourglassSum([
    [-9, -9, -9,  1, 1, 1],
    [ 0, -9,  0,  4, 3, 2],
    [-9, -9, -9,  1, 2, 3],
    [ 0,  0,  8,  6, 6, 0],
    [ 0,  0,  0, -2, 0, 0],
    [ 0,  0,  1,  2, 4, 0],
]);

console.log(maxSum1);

const maxSum2 = hourglassSum([
    [1, 1, 1, 0, 0, 0],
    [0, 1, 0, 0, 0, 0],
    [1, 1, 1, 0, 0, 0],
    [0, 0, 2, 4, 4, 0],
    [0, 0, 0, 2, 0, 0],
    [0, 0, 1, 2, 4, 0],
]);

console.log(maxSum2);