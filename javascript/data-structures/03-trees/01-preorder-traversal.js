const utils = require('./utilities.js');
const root = utils.tree;

function preOrder(root) {
    function traverse(root, result) {
        result.push(root.data);
        if (root.left) traverse(root.left, result);
        if (root.right) traverse(root.right, result);
    }

    const result = [];
    traverse(root, result);
    console.log(result.join(' '));
}

preOrder(root);