CREATE USER cardb IDENTIFIED BY 1234
default tablespace users
temporary tablespace temp;

GRANT CONNECT TO cardb;
GRANT RESOURCE TO cardb;
GRANT DBA TO cardb;

-- customer #1
INSERT INTO customer VALUES (
    '김민준',
    '01073211713',
    '28',
    '남'
);

-- customer #2
INSERT INTO customer VALUES (
    '이도윤',
    '01022720189',
    '32',
    '남'
);

-- customer #3
INSERT INTO customer VALUES (
    '박지유',
    '01097792756',
    '24',
    '여'
);

-- customer #4
INSERT INTO customer VALUES (
    '최민석',
    '01053185577',
    '54',
    '남'
);

-- customer #5
INSERT INTO customer VALUES (
    '고채아',
    '01023187072',
    '41',
    '여'
);

-- customer #6
INSERT INTO customer VALUES (
    '신태양',
    '01026264123',
    '33',
    '남'
);

-- customer #7
INSERT INTO customer VALUES (
    '김가영',
    '01074761733',
    '30',
    '여'
);