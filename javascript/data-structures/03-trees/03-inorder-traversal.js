const utils = require('./utilities.js');
const root = utils.tree;

function inOrder(root) {
    function traverse(root, result) {
        if (root.left) traverse(root.left, result);
        result.push(root.data);
        if (root.right) traverse(root.right, result);
    }

    const result = [];
    traverse(root, result);
    console.log(result.join(' '));
}

inOrder(root);