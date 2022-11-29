from . import webot

def new_bot(port:int):
    '''新建一个微信机器人'''
    return webot.webot(port)