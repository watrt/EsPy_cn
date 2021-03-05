from machine import Pin, SPIfrom ili9163 import ILI9163_SPI,ILI9163import ujsonimport urequestsimport framebufimport _threadspi = SPI(baudrate=4000000,sck=Pin(33), mosi=Pin(25),miso=Pin(4))  #miso=Pin(4)是无交的因为必须配置所以乱写的
ili = ILI9163_SPI(128, 160, spi, res=Pin(27), dc=Pin(26), cs=Pin(4))ili.fill(0xFFFF)ili.fill_rect(5,5,56,50,ili.brg(r=255))ili.show()f=open("weather/0.bin")imgbyte=f.read()img=framebuf.FrameBuffer(bytearray(imgbyte),60,60,framebuf.RGB565)ili.blit(img,0,0)ili.show()



#测试中文