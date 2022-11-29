#pragma once
#include <mutex>

//from https://github.com/InsZVA/C11RWMutex/blob/master/rwmutex.h

class RWMutex {
private:
	std::mutex wm, rmm;
	std::unique_lock<std::mutex> rmtx;
	std::condition_variable cond;
	int rd_cnt = 0;	//wait for read
	bool wr_cnt = false;	//wait for write
public:
	RWMutex() : rmtx(rmm, std::defer_lock) {}
	void rLock() {
		while (wr_cnt)
			cond.wait(rmtx);
	}

	void rUnLock() {
		if (!wr_cnt)
			cond.notify_all();
	}

	void wLock() {
		wm.lock();
		while (wr_cnt)
			cond.wait(rmtx);
		wr_cnt = true;
		wm.unlock();
	}

	void wUnlock() {
		wm.lock();
		wr_cnt = false;
		if (!wr_cnt)
			cond.notify_all();
		wm.unlock();
	}
};