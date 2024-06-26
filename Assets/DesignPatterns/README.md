﻿# 오브젝트 풀(Object Pool)

재사용 가능한 객체들을 모아놓은 풀 클래스를 정의합니다.

이 풀 클래스안에 들어갈 객체들은 자신이 사용중인지에 대한 여부를 알 수 있는 방법을 제공해야 합니다.

풀은 초기화될 때, 사용할 객체들을 미리 생성합니다. (최초 1회)  
그 후 풀은 해당 객체들을 연속된 데이터(배열 / 리스트)에 보관하고 해당 객체들은 '사용 안함' 상태로 처리합니다.

사용자는 새로운 객체가 필요할 경우 풀에 요청을 진행합니다.

풀은 사용이 가능한 객체들을 배열 내에서 찾아내 사용 중으로 전환합니다.

해당 객체들이 더 이상 사용되지 않는다면 사용 안함 처리로 전환합니다.


## 해당 패턴으로 '생성'을 진행하는 이유

메모리 / 자원 할당을 신경 쓰지 않고 마음껏 객체에 대한 생성/삭제 가능
> 매번 생성 / 삭제를 하는 것보다 메모리 사용량 / 성능 저하를 줄이는 데 효과적입니다.

초기에 더 많은 메모리를 사용하게 된다는 단점도 존재하기는 합니다.  
(처음에 한번에 필요한 양을 미리 다 생성하는 방식이기 때문)