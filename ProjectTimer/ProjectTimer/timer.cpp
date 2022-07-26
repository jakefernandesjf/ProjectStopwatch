#include "timer.h"

using namespace std::chrono;

#pragma region timer Methods
// Constructors and Destructors
timer::timer()
{
	startPoint = steady_clock::now();
	activeStatus = true;
	millisecondsElapsed = 0ns;
	name = "";
}


timer::timer(string _name) : name(_name)
{
	startPoint = steady_clock::now();
	activeStatus = true;
	millisecondsElapsed = 0ns;
}


// Other Public Methods
void timer::pauseTimer()
{
	if (!isTimerActive())
	{
		// Do nothing
	}
	else
	{
		activeStatus = false;
		millisecondsElapsed = millisecondsElapsed + (steady_clock::now() - startPoint);
	}
}


void timer::startTimer()
{
	auto newStartPoint = steady_clock::now();
	if (isTimerActive())
	{
		// Do nothing
	}
	else
	{
		activeStatus = true;
		startPoint = newStartPoint;
	}
}


void timer::resetTimer()
{
	startPoint = steady_clock::now();
	millisecondsElapsed = 0ns;
}


nanoseconds timer::getTimeElapsed()
{
	if (isTimerActive())
	{
		return steady_clock::now() - startPoint + millisecondsElapsed;
	}
	else 
	{
		return millisecondsElapsed;
	}
}


bool timer::isTimerActive()
{
	return activeStatus;
}


void timer::addTime(milliseconds _milliseconds)
{
	millisecondsElapsed = millisecondsElapsed + _milliseconds;
}


void timer::subtractTime(chrono::milliseconds _milliseconds)
{
	millisecondsElapsed = millisecondsElapsed - _milliseconds;
}


void timer::setName(string _name)
{
	name = _name;
}


string timer::getName()
{
	return name;
}


// Private Methods
void timer::setActiveStatus(bool _status)
{
	activeStatus = _status;
}
#pragma endregion


#pragma region totalTimer Methods
// Constructors and Destructors
totalTimer::totalTimer() : timer()
{
	vector<timer> subTimers ( {timer("Enter name of timer")});
	activeSubTimerPointer = &subTimers.front();
}


totalTimer::totalTimer(string _name, vector<timer> _subTimers) : timer(_name)
{
	subTimers = _subTimers;
	activeSubTimerPointer = &subTimers.front();
}


// Other Public Methods
void totalTimer::pauseTimer()
{
	// TODO: improve with threading?
	pauseTimer();
	pauseActiveSubTimer();
}


void totalTimer::addSubTimer(timer _subTimer)
{
	subTimers.push_back(_subTimer);
}


void totalTimer::removeSubTimer(int _position)
{
	subTimers.erase(subTimers.begin() + _position);
}


vector<timer> totalTimer::getSubTimers()
{
	return subTimers;
}


void totalTimer::setAndStartActiveSubTimer(int _position)
{
	activeSubTimerPointer = &subTimers.at(_position);
	startActiveSubTimer();
}


timer totalTimer::getActiveSubTimer()
{
	return *activeSubTimerPointer;
}


// Private Methods
void totalTimer::startActiveSubTimer()
{
	// TODO: improve with threading?
	activeSubTimerPointer->startTimer();
	startTimer();
}


void totalTimer::pauseActiveSubTimer()
{
	activeSubTimerPointer->pauseTimer();
}
#pragma endregion