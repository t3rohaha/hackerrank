class Node {
    constructor(data, left = null, right = null) {
        this.data = data;
        this.left = left;
        this.right = right;
    }
}

const tree =
{
    data: 1,
    left: null,
    right:
    {
        data: 2,
        left: null,
        right:
        {
            data: 5,
            left:
            {
                data: 3,
                left: null,
                right:
                {
                    data: 4,
                    left: null,
                    right: null
                }
            },
            right:
            {
                data: 6,
                left: null,
                right: null
            }
        }
    }
};

module.exports = { Node, tree };