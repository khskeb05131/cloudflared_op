대한민국의 통치 원리를 담고 있는 헌법은 다음과 같은 조항을 가지고 있다.

>  **헌법** 제18조 (통신의 비밀) 모든 국민은 통신의 비밀을 침해받지 아니한다. 

그러나 그러한 통치에서 종속되는 일선 교육기관인 우리 부산고등학교는 이러한 당연스러운 헌법의 조항에 대하여 전면적으로 배치되는 행동을 하고 있다. 부산고등학교의 기숙사는 학생의 편안한 교육환경을 위하여 주거생활을 제공하기 위하여 창립되었지만, 학생을 위한다고는 전혀 보아질 수 없는  인터넷 사찰 및 감시로 하여금 당연시하게 받아들여지는 인권 찬탈은 이루 말할 수 없을 정도로 심각한 수준이다.

누구도 예상하지 못하였겠지만, 기숙사의 특정 사이트에 대한 접속의 차단은 단순히 특정 도메인으로의 접속 차단의 수준이 아닌, 의도적인 DNS변조를 통한 사이트 차단을 통해 이루어 지고 있다.

이러한 막심한 행태에 대한 대응으로 우리 기숙사생도들은 이 프로그램을 이용하여 소극적으로나마 우리의 통신의 자유에 대한 권리의 개진을 행하고자 한다.

---

1. cloudflare.com 에 가입한다.

2. namecheap.com 등 도메인 구입 사이트에서 아주 저렴한 도메인 하나를 구입한다.

3. cloudflare.com 에 해당 도메인을 등록한다.

   * 등록 시 네임서버의 변경에 유의하도록 하자.

4. cloudflared.exe 클라이언트를 검색하여 실행하자.

5. config 를 통하여 계정 설정을 하도록 하자.

6. 명령어 cloudflared.exe proxy-dns 를 통하여 CLOUDFALRE DoH 서비스가 정상적으로 실행되었을 것이다.

7. 사용하고자 하는 네트워크 인터페이스의 설정에서 DNS의 설정을 루트백 IP로 변경한다.(127.0.0.1)

   

   * DoH: DNS over HTTPS의 약자
