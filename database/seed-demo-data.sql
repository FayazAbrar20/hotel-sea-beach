USE LoginDB;
GO

-- Demo data for screenshots. All demo accounts use the password: Password123

IF NOT EXISTS (SELECT 1 FROM registrationone WHERE username = 'rahim.k')
    INSERT INTO registrationone (role, username, password, email, mobile, dob, gender, address, status) VALUES ('Employee', 'rahim.k', 'PBKDF2$100000$02rrg/IrSynGeiMRWvtzUA==$BehFe7QwgN1t3Oz0NSc/1yLh/5Iq70qc5YHbIBEW35o=', 'rahim.karim@gmail.com', '01711234567', '1995-03-14', 'Male', 'House 12, Road 5, Dhanmondi, Dhaka', 1);
IF NOT EXISTS (SELECT 1 FROM registrationone WHERE username = 'nusrat.j')
    INSERT INTO registrationone (role, username, password, email, mobile, dob, gender, address, status) VALUES ('Employee', 'nusrat.j', 'PBKDF2$100000$oKoiTXMg2WUOjY8j6DClbw==$7CPrOX92+xlzDxRzR/60nZ6qSk2mFmtHjS2tQL+xnkY=', 'nusrat.jahan@gmail.com', '01812345678', '1997-07-22', 'Female', 'Flat 4B, Block C, Bashundhara R/A, Dhaka', 1);
IF NOT EXISTS (SELECT 1 FROM registrationone WHERE username = 'tanvir.h')
    INSERT INTO registrationone (role, username, password, email, mobile, dob, gender, address, status) VALUES ('Employee', 'tanvir.h', 'PBKDF2$100000$Qwga57K2G2icwtFFkLExPw==$SHlpM3saKfSteDWBtXT8cHli9HNhtteITqYIetZik7U=', 'tanvir.hasan@yahoo.com', '01913456789', '1993-11-02', 'Male', '45 Agrabad C/A, Chattogram', 1);
IF NOT EXISTS (SELECT 1 FROM registrationone WHERE username = 'sadia.r')
    INSERT INTO registrationone (role, username, password, email, mobile, dob, gender, address, status) VALUES ('Employee', 'sadia.r', 'PBKDF2$100000$tyr0uOm+pP20mBDvwk0l1Q==$JWBRFFzOtHwMQlbgdf7QxCYt8s12L+vL8VPbe1kvl6U=', 'sadia.rahman@gmail.com', '01614567890', '1999-01-30', 'Female', '22 Zindabazar, Sylhet', 0);
IF NOT EXISTS (SELECT 1 FROM registrationone WHERE username = 'arif.chowdhury')
    INSERT INTO registrationone (role, username, password, email, mobile, dob, gender, address, status) VALUES ('Customer', 'arif.chowdhury', 'PBKDF2$100000$fnSbJjKOmlzH99O07oQuuw==$+kS4nNemS9HMSGHH/ka+sZm0jU5nJ6VHvlWd33LOMtQ=', 'arif.chowdhury@gmail.com', '01715678901', '1988-05-19', 'Male', 'Road 11, Banani, Dhaka', 1);
IF NOT EXISTS (SELECT 1 FROM registrationone WHERE username = 'farhana.akter')
    INSERT INTO registrationone (role, username, password, email, mobile, dob, gender, address, status) VALUES ('Customer', 'farhana.akter', 'PBKDF2$100000$20rSPhk16eXaCHm6F0FR+Q==$7uAixHKdngBt7aZQNsBr8dtwxvmmCjMcfnVZR76T7Do=', 'farhana.akter@outlook.com', '01816789012', '1992-09-08', 'Female', 'Sector 7, Uttara, Dhaka', 1);
IF NOT EXISTS (SELECT 1 FROM registrationone WHERE username = 'imran.hossain')
    INSERT INTO registrationone (role, username, password, email, mobile, dob, gender, address, status) VALUES ('Customer', 'imran.hossain', 'PBKDF2$100000$lhNuclF4O0+SWyGVNQi9Mw==$5OsQM3Jcs6jTnfR3vs2s2VCFly4wJ8pe8n5HQmIF8Dk=', 'imran.hossain@gmail.com', '01917890123', '1985-12-25', 'Male', 'Kazir Dewri, Chattogram', 1);
IF NOT EXISTS (SELECT 1 FROM registrationone WHERE username = 'mehnaz.islam')
    INSERT INTO registrationone (role, username, password, email, mobile, dob, gender, address, status) VALUES ('Customer', 'mehnaz.islam', 'PBKDF2$100000$MdkP6QvRbEUSyBWz/mMN1g==$lqTGxPj0zOcBaT9+Ujf0kdt0en9AWZ0B9DgkAQwwYxM=', 'mehnaz.islam@gmail.com', '01518901234', '1996-04-11', 'Female', 'Shaheb Bazar, Rajshahi', 1);
IF NOT EXISTS (SELECT 1 FROM registrationone WHERE username = 'sakib.ahmed')
    INSERT INTO registrationone (role, username, password, email, mobile, dob, gender, address, status) VALUES ('Customer', 'sakib.ahmed', 'PBKDF2$100000$GzVZQujbtsSNaRQm9AI/Aw==$oWSHhFulEsl+YyezO2vXhwuPyWlGog0tG37faZm6te4=', 'sakib.ahmed@yahoo.com', '01319012345', '1990-08-03', 'Male', 'KDA Avenue, Khulna', 1);
IF NOT EXISTS (SELECT 1 FROM registrationone WHERE username = 'tasnim.haque')
    INSERT INTO registrationone (role, username, password, email, mobile, dob, gender, address, status) VALUES ('Customer', 'tasnim.haque', 'PBKDF2$100000$c6wrIM5NowqgWsmT/9THbA==$MJlZniXnqJcspq5JcOhQRjtvdG9lv/QQ9VBYRFLvxOU=', 'tasnim.haque@gmail.com', '01720123456', '1998-02-17', 'Female', 'Mirpur 10, Dhaka', 0);
IF NOT EXISTS (SELECT 1 FROM registrationone WHERE username = 'rafiq.uddin')
    INSERT INTO registrationone (role, username, password, email, mobile, dob, gender, address, status) VALUES ('Customer', 'rafiq.uddin', 'PBKDF2$100000$wp+INkCopgZW3hvrh1kNPw==$QyUPpI9nz8oUdQMOWDzAliEMjvq76plPVK3Q42B5xDo=', 'rafiq.uddin@gmail.com', '01821234560', '1979-06-29', 'Male', 'Kolatoli Road, Coxs Bazar', 1);
IF NOT EXISTS (SELECT 1 FROM registrationone WHERE username = 'nadia.sultana')
    INSERT INTO registrationone (role, username, password, email, mobile, dob, gender, address, status) VALUES ('Customer', 'nadia.sultana', 'PBKDF2$100000$5anuefhEJ4mUSue8QiO4Ww==$TS3UmaeJ92GxwJB747LjndudDQWn+WM9tCH5nO/+KVg=', 'nadia.sultana@gmail.com', '01922345601', '1994-10-05', 'Female', 'Gulshan 2, Dhaka', 0);
GO

IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '101')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('101', 'single bed', 'NON-AC', 2000, 'NO');
IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '102')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('102', 'double bed', 'NON-AC', 3200, 'YES');
IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '103')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('103', 'triple bed', 'NON-AC', 4500, 'NO');
IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '104')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('104', 'single bed', 'AC', 3500, 'NO');
IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '105')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('105', 'double bed', 'AC', 5500, 'YES');
IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '106')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('106', 'triple bed', 'AC', 7500, 'NO');
IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '201')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('201', 'single bed', 'AC', 4000, 'YES');
IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '202')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('202', 'double bed', 'AC', 6000, 'NO');
IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '203')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('203', 'triple bed', 'AC', 8000, 'YES');
IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '204')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('204', 'single bed', 'AC', 4000, 'NO');
IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '205')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('205', 'double bed', 'AC', 6000, 'NO');
IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '206')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('206', 'triple bed', 'AC', 8000, 'YES');
IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '301')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('301', 'single bed', 'AC', 4500, 'NO');
IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '302')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('302', 'double bed', 'AC', 6500, 'YES');
IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '303')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('303', 'triple bed', 'AC', 8500, 'NO');
IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '304')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('304', 'single bed', 'AC', 4500, 'YES');
IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '305')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('305', 'double bed', 'AC', 6500, 'YES');
IF NOT EXISTS (SELECT 1 FROM addroom WHERE roomnumber = '306')
    INSERT INTO addroom (roomnumber, bedtype, roomtype, price, booked) VALUES ('306', 'triple bed', 'AC', 8500, 'NO');
GO

IF NOT EXISTS (SELECT 1 FROM Customerroombook WHERE roomnumber = '102')
    INSERT INTO Customerroombook (roomid, roomnumber, bedtype, roomtype, price, numberOfDays, PricePerDay, booked) SELECT roomid, roomnumber, bedtype, roomtype, 9600, 3, 3200, 'Yes' FROM addroom WHERE roomnumber = '102';
IF NOT EXISTS (SELECT 1 FROM Customerroombook WHERE roomnumber = '105')
    INSERT INTO Customerroombook (roomid, roomnumber, bedtype, roomtype, price, numberOfDays, PricePerDay, booked) SELECT roomid, roomnumber, bedtype, roomtype, 11000, 2, 5500, 'Yes' FROM addroom WHERE roomnumber = '105';
IF NOT EXISTS (SELECT 1 FROM Customerroombook WHERE roomnumber = '201')
    INSERT INTO Customerroombook (roomid, roomnumber, bedtype, roomtype, price, numberOfDays, PricePerDay, booked) SELECT roomid, roomnumber, bedtype, roomtype, 20000, 5, 4000, 'Yes' FROM addroom WHERE roomnumber = '201';
IF NOT EXISTS (SELECT 1 FROM Customerroombook WHERE roomnumber = '203')
    INSERT INTO Customerroombook (roomid, roomnumber, bedtype, roomtype, price, numberOfDays, PricePerDay, booked) SELECT roomid, roomnumber, bedtype, roomtype, 8000, 1, 8000, 'Yes' FROM addroom WHERE roomnumber = '203';
IF NOT EXISTS (SELECT 1 FROM Customerroombook WHERE roomnumber = '206')
    INSERT INTO Customerroombook (roomid, roomnumber, bedtype, roomtype, price, numberOfDays, PricePerDay, booked) SELECT roomid, roomnumber, bedtype, roomtype, 32000, 4, 8000, 'Yes' FROM addroom WHERE roomnumber = '206';
IF NOT EXISTS (SELECT 1 FROM Customerroombook WHERE roomnumber = '302')
    INSERT INTO Customerroombook (roomid, roomnumber, bedtype, roomtype, price, numberOfDays, PricePerDay, booked) SELECT roomid, roomnumber, bedtype, roomtype, 45500, 7, 6500, 'Yes' FROM addroom WHERE roomnumber = '302';
IF NOT EXISTS (SELECT 1 FROM Customerroombook WHERE roomnumber = '304')
    INSERT INTO Customerroombook (roomid, roomnumber, bedtype, roomtype, price, numberOfDays, PricePerDay, booked) SELECT roomid, roomnumber, bedtype, roomtype, 9000, 2, 4500, 'Yes' FROM addroom WHERE roomnumber = '304';
IF NOT EXISTS (SELECT 1 FROM Customerroombook WHERE roomnumber = '305')
    INSERT INTO Customerroombook (roomid, roomnumber, bedtype, roomtype, price, numberOfDays, PricePerDay, booked) SELECT roomid, roomnumber, bedtype, roomtype, 19500, 3, 6500, 'Yes' FROM addroom WHERE roomnumber = '305';
GO

INSERT INTO LoginHistory (username, login_time) VALUES ('tanvir.h', DATEADD(MINUTE, -4973, GETDATE()));
INSERT INTO LoginHistory (username, login_time) VALUES ('imran.hossain', DATEADD(MINUTE, -1612, GETDATE()));
INSERT INTO LoginHistory (username, login_time) VALUES ('rahim.k', DATEADD(MINUTE, -17589, GETDATE()));
INSERT INTO LoginHistory (username, login_time) VALUES ('rahim.k', DATEADD(MINUTE, -12012, GETDATE()));
INSERT INTO LoginHistory (username, login_time) VALUES ('rafiq.uddin', DATEADD(MINUTE, -1930, GETDATE()));
INSERT INTO LoginHistory (username, login_time) VALUES ('sakib.ahmed', DATEADD(MINUTE, -7065, GETDATE()));
INSERT INTO LoginHistory (username, login_time) VALUES ('manager', DATEADD(MINUTE, -2846, GETDATE()));
INSERT INTO LoginHistory (username, login_time) VALUES ('imran.hossain', DATEADD(MINUTE, -13732, GETDATE()));
INSERT INTO LoginHistory (username, login_time) VALUES ('rahim.k', DATEADD(MINUTE, -7916, GETDATE()));
INSERT INTO LoginHistory (username, login_time) VALUES ('rahim.k', DATEADD(MINUTE, -18086, GETDATE()));
INSERT INTO LoginHistory (username, login_time) VALUES ('imran.hossain', DATEADD(MINUTE, -1966, GETDATE()));
INSERT INTO LoginHistory (username, login_time) VALUES ('rafiq.uddin', DATEADD(MINUTE, -4086, GETDATE()));
INSERT INTO LoginHistory (username, login_time) VALUES ('arif.chowdhury', DATEADD(MINUTE, -19133, GETDATE()));
INSERT INTO LoginHistory (username, login_time) VALUES ('manager', DATEADD(MINUTE, -18940, GETDATE()));
INSERT INTO LoginHistory (username, login_time) VALUES ('rafiq.uddin', DATEADD(MINUTE, -13028, GETDATE()));
GO
