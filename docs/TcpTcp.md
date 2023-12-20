# SonicWallGen7.Model.TcpTcp
Configure TCP settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnforceStrictCompliance** | **bool** | Enable enforcement of strict TCP compliance with RFC 793 and RFC 1122. | [optional] 
**HandshakeEnforcement** | **bool** | Enable TCP handshake enforcement. | [optional] 
**ChecksumEnforcement** | **bool** | Enable TCP checksum enforcement. | [optional] 
**Drop** | [**TcpTcpDrop**](TcpTcpDrop.md) |  | [optional] 
**EnableHandshakeTimeout** | **bool** | Enable the TCP handshake timeout configure. | [optional] 
**HandshakeTimeout** | **decimal** | Set the TCP handshake timeout in seconds. | [optional] 
**DefaultConnectionTimeout** | **decimal** | Set default TCP connection timeout in minutes. | [optional] 
**MaximumSegmentLifetime** | **decimal** | Set maximum segment lifetime in seconds. | [optional] 
**HalfOpenThreshold** | **bool** | Enable half open TCP connections threshold. | [optional] 
**MaximumHalfOpenConnections** | **decimal** | Set maximum half open TCP connections. | [optional] 
**SynFloodProtectionMode** | **string** | Set TCP SYN flood protection mode. | [optional] 
**SynAttackThreshold** | **decimal** | Set attack threshold (incomplete connection attempts / second). | [optional] 
**SupportTcpSack** | **bool** | Enable all LAN/DMZ servers support the TCP SACK option. | [optional] 
**EnableLimitMss** | **bool** | Enable limit MSS sent to WAN clients (when connections are proxied). | [optional] 
**LimitMssMax** | **decimal** | Set maximum TCP MSS sent to WAN clients. | [optional] 
**AlwaysLogSynPackets** | **bool** | Enable always log SYN packets received. | [optional] 
**ProxyConnections** | [**TcpTcpProxyConnections**](TcpTcpProxyConnections.md) |  | [optional] 
**SynFloodBlacklisting** | **bool** | Enable SYN/RST/FIN flood blacklisting on all interfaces. | [optional] 
**BlacklistThreshold** | **decimal** | Set threshold for SYN/RST/FIN flood blacklisting (packets / sec). | [optional] 
**NeverBlacklistWan** | **bool** | Enable never blacklist WAN machines. | [optional] 
**AlwaysAllowManagement** | **bool** | Enable always allow SonicWall management traffic. | [optional] 
**Ddos** | [**TcpTcpDdos**](TcpTcpDdos.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

