#!/bin/sh
for i in 1 2 3 4 5 6 7 "\*"
do
  echo "You are $i years old"
done

echo "Digite su edad!"
while [ "$EDAD" != 21 ]
do
  read EDAD
done
