#import fastFood as f  -> fastFood 대신 f로 사용가능
#from fastFood import pick as p  -> fastFood 의 pick만 사용
# 폴더에 넣었을 경우 경로 넣어주어야한다
from Sourecs import fastFood

place=fastFood.pick()
print("Let's go to",place)