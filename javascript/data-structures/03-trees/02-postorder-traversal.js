const utils = require('./utilities.js');
const root = utils.tree;

function postOrder(root) {
    function traverse(root, result) {
        if (root.left) traverse(root.left, result);
        if (root.right) traverse(root.right, result);
        result.push(root.data);
    }

    const result = [];
    traverse(root, result);
    console.log(result.join(' '));
}

postOrder(root);