function treeHeight(root) {
    function getHeight(node, height, result) {
        if (height > result.maxHeight) {
            result.maxHeight = height;
        }

        if (node.left) {
            getHeight(node.left, height + 1, result);
        }

        if (node.right) {
            getHeight(node.right, height + 1, result);
        }
    }

    let result = { maxHeight: 0 };
    getHeight(root, 0, result);

    return result.maxHeight.toString();
}

const tree = {
    data: 3,
    left: {
        data: 2,
        left: {
            data: 1,
            left: null,
            right: null
        },
        right: null
    },
    right: {
        data: 5,
        left: {
            data: 4,
            left: null,
            right: null
        },
        right: {
            data: 6,
            left: null,
            right: {
                data: 7,
                left: null,
                right: null
            }
        }
    }
}

console.log(treeHeight(tree));