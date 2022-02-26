from muselsl import stream, list_muses

muses = list_muses()
print(muses)
stream(muses[0]['address'], ppg_enabled=True, acc_enabled=True, gyro_enabled=True)

# Note: Streaming is synchronous, so code here will not execute until after the stream has been closed
print('Stream has ended')