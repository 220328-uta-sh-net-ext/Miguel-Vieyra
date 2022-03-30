#!/usr/bin/bash
# for a number between 1 to 20
# print fizz if a number is divisible by 3
# print buzz if the number is divisible by 5
# print fizzbuzz if the number is divisible by both 3 and 5
# print nothing if the number isn't divisible by 3 or 5.

NUM=1
until ((NUM == 101)) ; do
   if ((NUM % 15 == 0)) ; then
       echo FizzBuzz
   elif ((NUM % 3 == 0)) ; then
       echo Fizz
   elif ((NUM % 5 == 0)) ; then
       echo Buzz
   else 
       echo "$NUM"
   fi
   ((NUM = NUM + 1))
done