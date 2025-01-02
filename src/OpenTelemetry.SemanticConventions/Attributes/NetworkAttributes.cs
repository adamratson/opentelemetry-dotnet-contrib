// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

// <auto-generated>This file has been auto generated from 'src\OpenTelemetry.SemanticConventions\scripts\templates\registry\SemanticConventionsAttributes.cs.j2' </auto-generated>

#nullable enable

#pragma warning disable CS1570 // XML comment has badly formed XML

namespace OpenTelemetry.SemanticConventions;

/// <summary>
/// Constants for semantic attribute names outlined by the OpenTelemetry specifications.
/// </summary>
public static class NetworkAttributes
{
    /// <summary>
    /// The ISO 3166-1 alpha-2 2-character country code associated with the mobile carrier network.
    /// </summary>
    public const string AttributeNetworkCarrierIcc = "network.carrier.icc";

    /// <summary>
    /// The mobile carrier country code.
    /// </summary>
    public const string AttributeNetworkCarrierMcc = "network.carrier.mcc";

    /// <summary>
    /// The mobile carrier network code.
    /// </summary>
    public const string AttributeNetworkCarrierMnc = "network.carrier.mnc";

    /// <summary>
    /// The name of the mobile carrier.
    /// </summary>
    public const string AttributeNetworkCarrierName = "network.carrier.name";

    /// <summary>
    /// This describes more details regarding the connection.type. It may be the type of cell technology connection, but it could be used for describing details about a wifi connection.
    /// </summary>
    public const string AttributeNetworkConnectionSubtype = "network.connection.subtype";

    /// <summary>
    /// The internet connection type.
    /// </summary>
    public const string AttributeNetworkConnectionType = "network.connection.type";

    /// <summary>
    /// The network interface name.
    /// </summary>
    public const string AttributeNetworkInterfaceName = "network.interface.name";

    /// <summary>
    /// The network IO operation direction.
    /// </summary>
    public const string AttributeNetworkIoDirection = "network.io.direction";

    /// <summary>
    /// Local address of the network connection - IP address or Unix domain socket name.
    /// </summary>
    public const string AttributeNetworkLocalAddress = "network.local.address";

    /// <summary>
    /// Local port number of the network connection.
    /// </summary>
    public const string AttributeNetworkLocalPort = "network.local.port";

    /// <summary>
    /// Peer address of the network connection - IP address or Unix domain socket name.
    /// </summary>
    public const string AttributeNetworkPeerAddress = "network.peer.address";

    /// <summary>
    /// Peer port number of the network connection.
    /// </summary>
    public const string AttributeNetworkPeerPort = "network.peer.port";

    /// <summary>
    /// <a href="https://wikipedia.org/wiki/Application_layer">OSI application layer</a> or non-OSI equivalent.
    /// </summary>
    /// <remarks>
    /// The value SHOULD be normalized to lowercase.
    /// </remarks>
    public const string AttributeNetworkProtocolName = "network.protocol.name";

    /// <summary>
    /// The actual version of the protocol used for network communication.
    /// </summary>
    /// <remarks>
    /// If protocol version is subject to negotiation (for example using <a href="https://www.rfc-editor.org/rfc/rfc7301.html">ALPN</a>), this attribute SHOULD be set to the negotiated version. If the actual protocol version is not known, this attribute SHOULD NOT be set.
    /// </remarks>
    public const string AttributeNetworkProtocolVersion = "network.protocol.version";

    /// <summary>
    /// <a href="https://wikipedia.org/wiki/Transport_layer">OSI transport layer</a> or <a href="https://wikipedia.org/wiki/Inter-process_communication">inter-process communication method</a>.
    /// </summary>
    /// <remarks>
    /// The value SHOULD be normalized to lowercase.
    /// <p>
    /// Consider always setting the transport when setting a port number, since
    /// a port number is ambiguous without knowing the transport. For example
    /// different processes could be listening on TCP port 12345 and UDP port 12345.
    /// </remarks>
    public const string AttributeNetworkTransport = "network.transport";

    /// <summary>
    /// <a href="https://wikipedia.org/wiki/Network_layer">OSI network layer</a> or non-OSI equivalent.
    /// </summary>
    /// <remarks>
    /// The value SHOULD be normalized to lowercase.
    /// </remarks>
    public const string AttributeNetworkType = "network.type";

    /// <summary>
    /// This describes more details regarding the connection.type. It may be the type of cell technology connection, but it could be used for describing details about a wifi connection.
    /// </summary>
    public static class NetworkConnectionSubtypeValues
    {
        /// <summary>
        /// GPRS.
        /// </summary>
        public const string Gprs = "gprs";

        /// <summary>
        /// EDGE.
        /// </summary>
        public const string Edge = "edge";

        /// <summary>
        /// UMTS.
        /// </summary>
        public const string Umts = "umts";

        /// <summary>
        /// CDMA.
        /// </summary>
        public const string Cdma = "cdma";

        /// <summary>
        /// EVDO Rel. 0.
        /// </summary>
        public const string Evdo0 = "evdo_0";

        /// <summary>
        /// EVDO Rev. A.
        /// </summary>
        public const string EvdoA = "evdo_a";

        /// <summary>
        /// CDMA2000 1XRTT.
        /// </summary>
        public const string Cdma20001xrtt = "cdma2000_1xrtt";

        /// <summary>
        /// HSDPA.
        /// </summary>
        public const string Hsdpa = "hsdpa";

        /// <summary>
        /// HSUPA.
        /// </summary>
        public const string Hsupa = "hsupa";

        /// <summary>
        /// HSPA.
        /// </summary>
        public const string Hspa = "hspa";

        /// <summary>
        /// IDEN.
        /// </summary>
        public const string Iden = "iden";

        /// <summary>
        /// EVDO Rev. B.
        /// </summary>
        public const string EvdoB = "evdo_b";

        /// <summary>
        /// LTE.
        /// </summary>
        public const string Lte = "lte";

        /// <summary>
        /// EHRPD.
        /// </summary>
        public const string Ehrpd = "ehrpd";

        /// <summary>
        /// HSPAP.
        /// </summary>
        public const string Hspap = "hspap";

        /// <summary>
        /// GSM.
        /// </summary>
        public const string Gsm = "gsm";

        /// <summary>
        /// TD-SCDMA.
        /// </summary>
        public const string TdScdma = "td_scdma";

        /// <summary>
        /// IWLAN.
        /// </summary>
        public const string Iwlan = "iwlan";

        /// <summary>
        /// 5G NR (New Radio).
        /// </summary>
        public const string Nr = "nr";

        /// <summary>
        /// 5G NRNSA (New Radio Non-Standalone).
        /// </summary>
        public const string Nrnsa = "nrnsa";

        /// <summary>
        /// LTE CA.
        /// </summary>
        public const string LteCa = "lte_ca";
    }

    /// <summary>
    /// The internet connection type.
    /// </summary>
    public static class NetworkConnectionTypeValues
    {
        /// <summary>
        /// wifi.
        /// </summary>
        public const string Wifi = "wifi";

        /// <summary>
        /// wired.
        /// </summary>
        public const string Wired = "wired";

        /// <summary>
        /// cell.
        /// </summary>
        public const string Cell = "cell";

        /// <summary>
        /// unavailable.
        /// </summary>
        public const string Unavailable = "unavailable";

        /// <summary>
        /// unknown.
        /// </summary>
        public const string Unknown = "unknown";
    }

    /// <summary>
    /// The network IO operation direction.
    /// </summary>
    public static class NetworkIoDirectionValues
    {
        /// <summary>
        /// transmit.
        /// </summary>
        public const string Transmit = "transmit";

        /// <summary>
        /// receive.
        /// </summary>
        public const string Receive = "receive";
    }

    /// <summary>
    /// <a href="https://wikipedia.org/wiki/Transport_layer">OSI transport layer</a> or <a href="https://wikipedia.org/wiki/Inter-process_communication">inter-process communication method</a>.
    /// </summary>
    public static class NetworkTransportValues
    {
        /// <summary>
        /// TCP.
        /// </summary>
        public const string Tcp = "tcp";

        /// <summary>
        /// UDP.
        /// </summary>
        public const string Udp = "udp";

        /// <summary>
        /// Named or anonymous pipe.
        /// </summary>
        public const string Pipe = "pipe";

        /// <summary>
        /// Unix domain socket.
        /// </summary>
        public const string Unix = "unix";

        /// <summary>
        /// QUIC.
        /// </summary>
        public const string Quic = "quic";
    }

    /// <summary>
    /// <a href="https://wikipedia.org/wiki/Network_layer">OSI network layer</a> or non-OSI equivalent.
    /// </summary>
    public static class NetworkTypeValues
    {
        /// <summary>
        /// IPv4.
        /// </summary>
        public const string Ipv4 = "ipv4";

        /// <summary>
        /// IPv6.
        /// </summary>
        public const string Ipv6 = "ipv6";
    }
}
