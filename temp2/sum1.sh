# !/bin/bash -x

fun1(){
for (( i=0;i<5;i++ ));do
a=$((RANDOM%90+10))
sum=$(($sum+$a))
done
echo $sum
echo $(($sum/5))
}

fun1
