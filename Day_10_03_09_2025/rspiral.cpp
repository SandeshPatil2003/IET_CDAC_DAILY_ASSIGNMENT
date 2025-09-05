#include <iostream>
#include <vector>
#include <string>
#include <cmath>

#ifdef _WIN32
#include <windows.h>
#include <wincon.h>
#endif

using namespace std;

// ANSI color codes for rainbow
const string COLORS[] = {
    "\033[31m", // Red
    "\033[33m", // Yellow
    "\033[32m", // Green
    "\033[36m", // Cyan
    "\033[34m", // Blue
    "\033[35m", // Magenta
};
const string RESET = "\033[0m";
const int NUM_COLORS = 6;

// Function to enable ANSI escape codes on Windows
void enable_ansi_windows() {
#ifdef _WIN32
    #ifndef ENABLE_VIRTUAL_TERMINAL_PROCESSING
        const DWORD ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004;
    #endif

    HANDLE hOut = GetStdHandle(STD_OUTPUT_HANDLE);
    DWORD dwMode = 0;
    if (hOut != INVALID_HANDLE_VALUE && GetConsoleMode(hOut, &dwMode)) {
        dwMode |= ENABLE_VIRTUAL_TERMINAL_PROCESSING;
        SetConsoleMode(hOut, dwMode);
    }
#endif
}

// Function to calculate a vector of Fibonacci numbers
vector<int> get_fibonacci_sequence(int n) {
    if (n <= 1) return {1};
    vector<int> fib = {1, 1};
    for (int i = 2; i < n; ++i) {
        int next_fib = fib[i - 1] + fib[i - 2];
        if (next_fib > 40) break;
        fib.push_back(next_fib);
    }
    return fib;
}

// Function to draw an arc of the spiral
void draw_arc(vector<string>& canvas, int& x, int& y, int length, int direction, int color_index) {
    int start_x = x;
    int start_y = y;

    for (int i = 0; i < length; ++i) {
        if (x >= 0 && x < canvas[0].size() && y >= 0 && y < canvas.size()) {
            canvas[y][x] = ' '; // Placeholder, colors are applied later
        }

        if (direction == 0) x++; // right
        else if (direction == 1) y--; // up
        else if (direction == 2) x--; // left
        else if (direction == 3) y++; // down
    }
    
    // Now, go back and add the curve characters for the arc
    for (int i = 0; i < length; ++i) {
        int current_x, current_y;
        if (direction == 0) {
            current_x = start_x + i;
            current_y = start_y;
        } else if (direction == 1) {
            current_x = start_x;
            current_y = start_y - i;
        } else if (direction == 2) {
            current_x = start_x - i;
            current_y = start_y;
        } else { // direction == 3
            current_x = start_x;
            current_y = start_y + i;
        }

        if (current_x >= 0 && current_x < canvas[0].size() && current_y >= 0 && current_y < canvas.size()) {
            if (direction == 0) canvas[current_y][current_x] = '_';
            else if (direction == 1) canvas[current_y][current_x] = '|';
            else if (direction == 2) canvas[current_y][current_x] = '_';
            else if (direction == 3) canvas[current_y][current_x] = '|';
        }
    }
    
    // Add corners for a better visual effect
    if (length > 0) {
        if (direction == 0 && x >= 0 && y >= 0) canvas[y][x] = '\\';
        else if (direction == 1 && x >= 0 && y >= 0) canvas[y][x] = '/';
        else if (direction == 2 && x >= 0 && y >= 0) canvas[y][x] = '\\';
        else if (direction == 3 && x >= 0 && y >= 0) canvas[y][x] = '/';
    }
}

int main() {
    enable_ansi_windows();

    int n = 10;
    vector<int> fib = get_fibonacci_sequence(n);

    int max_size = 0;
    for (int f : fib) {
        max_size += f;
    }
    
    vector<string> canvas(max_size * 2, string(max_size * 2, ' '));

    int x = max_size;
    int y = max_size;
    int direction = 0; // 0=right, 1=up, 2=left, 3=down
    int color_index = 0;

    for (int i = 0; i < fib.size(); ++i) {
        draw_arc(canvas, x, y, fib[i], direction, color_index);
        direction = (direction + 1) % 4;
        color_index = (color_index + 1) % NUM_COLORS;
    }

    int min_x = canvas.size(), max_x = 0, min_y = canvas.size(), max_y = 0;
    for (int i = 0; i < canvas.size(); ++i) {
        for (int j = 0; j < canvas[i].size(); ++j) {
            if (canvas[i][j] != ' ') {
                if (i < min_y) min_y = i;
                if (i > max_y) max_y = i;
                if (j < min_x) min_x = j;
                if (j > max_x) max_x = j;
            }
        }
    }

    cout << "Fibonacci Spiral in Rainbow Colors:" << endl << endl;
    color_index = 0;
    for (int i = min_y; i <= max_y; ++i) {
        for (int j = min_x; j <= max_x; ++j) {
            if (canvas[i][j] != ' ') {
                cout << COLORS[color_index] << canvas[i][j];
                color_index = (color_index + 1) % NUM_COLORS;
            } else {
                cout << ' ';
            }
        }
        cout << RESET << endl;
    }

    return 0;
}