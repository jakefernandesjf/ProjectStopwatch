#include <iostream>
#include <chrono>
#include <vector>

using namespace std;

#pragma once
class timer
{
public:
	// Constructors and Destructor
	timer();
	timer(string _name);
	// Methods
	void pauseTimer();
	void startTimer();
	void resetTimer();
	chrono::nanoseconds getTimeElapsed();
	bool isTimerActive();
	void addTime(chrono::milliseconds _milliseconds);
	void subtractTime(chrono::milliseconds _milliseconds);
	void setName(string _name);
	string getName();
private:
	// Methods
	void setActiveStatus(bool _status);
	// Fields
	chrono::steady_clock::time_point startPoint;
	chrono::nanoseconds millisecondsElapsed;
	bool activeStatus;
	string name;
};


class totalTimer : public timer
{
public:
	// Constructors and Destructor
	totalTimer();
	totalTimer(string _name, vector<timer> _subTimers);
	// Methods
	void pauseTimer();
	void addSubTimer(timer _subTimer);
	void removeSubTimer(int _position);
	vector<timer> getSubTimers();
	void setAndStartActiveSubTimer(int _position);
	timer getActiveSubTimer();
private:
	// Methods
	void startActiveSubTimer();
	void pauseActiveSubTimer();
	// Fields
	vector<timer> subTimers;	
	timer *activeSubTimerPointer;
};

