# One Month Preparation Kit

## DateTime Formats

`dd` Converts the day of month, from 01 to 31.

`MM` Converts the month, from 01 to 12.

`yyyy` Converts the year, from 0000 to 9999.

`hh` Converts the hours, from 00 to 12.

`HH` Converts the hours, from 00 to 24.

`mm` Converts the minutes, from 00 to 59.

`ss` Converts the seconds, from 00 to 59.

`tt` AM/PM designator.

## Bitwise and Shift Operators

`~` Bitwise complement operator reverses each bit.

`<<` Left shift operator moves bits to left and inserts 0s to the right.

`>>` Right shift operator moves bits to right and inserts 0s to the left if
the number is positive and 1s if its negative.

`>>>` Unsigned right-shift operator moves bits to right and always inserts 0s
to the left.

`&` Bitwise AND operator.
- Compares each bit of the `operands`.
- If both are 1s the result is 1, otherwise 0.

`^` Bitwise XOR (exclusive or).
- Compares each bit of the `operands`.
- If bits are different the result will be 1, otherwise 0.

`|` Bitwise OR.
- Compares each bit of the `operands`.
- If atleast 1 of the bits is 1 the result will be 1, otherwise 0.

`Integer literals` Specify the format of an integer.
- `decimal` The default format of a number (no prefix).
- `hexadecimal` 0x or 0X prefix.
- `binary` 0b prefix.

### Notes

- These operators are defined for the integer types and char. The logical
operators can also be used with bool.

- Bitwise operators never cause overflow.

- `8 bits` can be represented as `0b_0000_0000`.

- Different types have different sizes in memory, so performing bitwise
operations on them will result in different values.

## Reference
[1 Month Preparation Kit](https://www.hackerrank.com/interview/preparation-kits/one-month-preparation-kit/one-month-week-one/challenges)