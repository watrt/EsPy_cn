# MicroPython IDE for ESP32

## v2.0.0.2


### 依赖:

- MS Windows 7
- MS .NET Framework 4.6

### 特性:

- 代码编辑
- 终端运行
- 文件管理
- 自带烧写工具
- 全部完成汉化
- 优化操作
- 支持中文IDE
- 优化布局

**安装扩展 Python intsallation:**

- python -m pip install --upgrade pip  
- python -m pip install esptool

### 快速开始:



**quick test:**
```python
  from machine import Pin
  import time

  p = Pin(2, Pin.OUT)

  for i in range(5):
    print(i)
    time.sleep_ms(500)
    p.low()
    time.sleep_ms(500)
    p.high()
```

