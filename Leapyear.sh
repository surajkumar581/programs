#!/bin/bash -x
echo "enter year:"
read y
year =$y
y=$(($y%4==0 || $y%400==0) && ($y%100!=0))
if[$y-eqo]
then
echo"$year is leap year!"
else
echo"$year is not leap year!"
 


