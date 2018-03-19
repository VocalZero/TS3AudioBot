// TS3Client - A free TeamSpeak3 client implementation
// Copyright (C) 2017  TS3Client contributors
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the Open Software License v. 3.0
//
// You should have received a copy of the Open Software License along with this
// program. If not, see <https://opensource.org/licenses/OSL-3.0>.











namespace TS3Client
{
	// Source: http://forum.teamspeak.com/threads/102276-Server-query-error-id-list
	public enum Ts3ErrorCode : uint
	{
		// ReSharper disable InconsistentNaming, UnusedMember.Global
		/// <summary>unknown error code</summary>
		ok = 0x0000,
		/// <summary>undefined error</summary>
		undefined = 0x0001,
		/// <summary>not implemented</summary>
		not_implemented = 0x0002,
		/// <summary></summary>
		ok_no_update = 0x0003,
		/// <summary></summary>
		dont_notify = 0x0004,
		/// <summary>library time limit reached</summary>
		lib_time_limit_reached = 0x0005,
		/// <summary>command not found</summary>
		command_not_found = 0x0100,
		/// <summary>unable to bind network port</summary>
		unable_to_bind_network_port = 0x0101,
		/// <summary>no network port available</summary>
		no_network_port_available = 0x0102,
		/// <summary>invalid clientID</summary>
		client_invalid_id = 0x0200,
		/// <summary>nickname is already in use</summary>
		client_nickname_inuse = 0x0201,
		/// <summary>invalid error code</summary>
		client_invalid_error_code = 0x0202,
		/// <summary>max clients protocol limit reached</summary>
		client_protocol_limit_reached = 0x0203,
		/// <summary>invalid client type</summary>
		client_invalid_type = 0x0204,
		/// <summary>already subscribed</summary>
		client_already_subscribed = 0x0205,
		/// <summary>not logged in</summary>
		client_not_logged_in = 0x0206,
		/// <summary>could not validate client identity</summary>
		client_could_not_validate_identity = 0x0207,
		/// <summary>invalid loginname or password</summary>
		client_invalid_password = 0x0208,
		/// <summary>too many clones already connected</summary>
		client_too_many_clones_connected = 0x0209,
		/// <summary>client version outdated, please update</summary>
		client_version_outdated = 0x020a,
		/// <summary>client is online</summary>
		client_is_online = 0x020b,
		/// <summary>client is flooding</summary>
		client_is_flooding = 0x020c,
		/// <summary>client is modified</summary>
		client_hacked = 0x020d,
		/// <summary>can not verify client at this moment</summary>
		client_cannot_verify_now = 0x020e,
		/// <summary>client is not permitted to log in</summary>
		client_login_not_permitted = 0x020f,
		/// <summary>client is not subscribed to the channel</summary>
		client_not_subscribed = 0x0210,
		/// <summary>invalid channelID</summary>
		channel_invalid_id = 0x0300,
		/// <summary>max channels protocol limit reached</summary>
		channel_protocol_limit_reached = 0x0301,
		/// <summary>already member of channel</summary>
		channel_already_in = 0x0302,
		/// <summary>channel name is already in use</summary>
		channel_name_inuse = 0x0303,
		/// <summary>channel not empty</summary>
		channel_not_empty = 0x0304,
		/// <summary>can not delete default channel</summary>
		channel_can_not_delete_default = 0x0305,
		/// <summary>default channel requires permanent</summary>
		channel_default_require_permanent = 0x0306,
		/// <summary>invalid channel flags</summary>
		channel_invalid_flags = 0x0307,
		/// <summary>permanent channel can not be child of non permanent channel</summary>
		channel_parent_not_permanent = 0x0308,
		/// <summary>channel maxclient reached</summary>
		channel_maxclients_reached = 0x0309,
		/// <summary>channel maxfamily reached</summary>
		channel_maxfamily_reached = 0x030a,
		/// <summary>invalid channel order</summary>
		channel_invalid_order = 0x030b,
		/// <summary>channel does not support filetransfers</summary>
		channel_no_filetransfer_supported = 0x030c,
		/// <summary>invalid channel password</summary>
		channel_invalid_password = 0x030d,
		/// <summary>channel is private channel</summary>
		channel_is_private_channel = 0x030e,
		/// <summary>invalid security hash supplied by client</summary>
		channel_invalid_security_hash = 0x030f,
		/// <summary>invalid serverID</summary>
		server_invalid_id = 0x0400,
		/// <summary>server is running</summary>
		server_running = 0x0401,
		/// <summary>server is shutting down</summary>
		server_is_shutting_down = 0x0402,
		/// <summary>server maxclient reached</summary>
		server_maxclients_reached = 0x0403,
		/// <summary>invalid server password</summary>
		server_invalid_password = 0x0404,
		/// <summary>deployment active</summary>
		server_deployment_active = 0x0405,
		/// <summary>unable to stop own server in your connection class</summary>
		server_unable_to_stop_own_server = 0x0406,
		/// <summary>server is virtual</summary>
		server_is_virtual = 0x0407,
		/// <summary>server wrong machineID</summary>
		server_wrong_machineid = 0x0408,
		/// <summary>server is not running</summary>
		server_is_not_running = 0x0409,
		/// <summary>server is booting up</summary>
		server_is_booting = 0x040a,
		/// <summary>server got an invalid status for this operation</summary>
		server_status_invalid = 0x040b,
		/// <summary>server modal quit</summary>
		server_modal_quit = 0x040c,
		/// <summary>server version is too old for command</summary>
		server_version_outdated = 0x040d,
		/// <summary>database error</summary>
		database = 0x0500,
		/// <summary>database empty result set</summary>
		database_empty_result = 0x0501,
		/// <summary>database duplicate entry</summary>
		database_duplicate_entry = 0x0502,
		/// <summary>database no modifications</summary>
		database_no_modifications = 0x0503,
		/// <summary>database invalid constraint</summary>
		database_constraint = 0x0504,
		/// <summary>database reinvoke command</summary>
		database_reinvoke = 0x0505,
		/// <summary>invalid quote</summary>
		parameter_quote = 0x0600,
		/// <summary>invalid parameter count</summary>
		parameter_invalid_count = 0x0601,
		/// <summary>invalid parameter</summary>
		parameter_invalid = 0x0602,
		/// <summary>parameter not found</summary>
		parameter_not_found = 0x0603,
		/// <summary>convert error</summary>
		parameter_convert = 0x0604,
		/// <summary>invalid parameter size</summary>
		parameter_invalid_size = 0x0605,
		/// <summary>missing required parameter</summary>
		parameter_missing = 0x0606,
		/// <summary>invalid checksum</summary>
		parameter_checksum = 0x0607,
		/// <summary>virtual server got a critical error</summary>
		vs_critical = 0x0700,
		/// <summary>Connection lost</summary>
		connection_lost = 0x0701,
		/// <summary>not connected</summary>
		not_connected = 0x0702,
		/// <summary>no cached connection info</summary>
		no_cached_connection_info = 0x0703,
		/// <summary>currently not possible</summary>
		currently_not_possible = 0x0704,
		/// <summary>failed connection initialization</summary>
		failed_connection_initialisation = 0x0705,
		/// <summary>could not resolve hostname</summary>
		could_not_resolve_hostname = 0x0706,
		/// <summary>invalid server connection handler ID</summary>
		invalid_server_connection_handler_id = 0x0707,
		/// <summary>could not initialize Input Manager</summary>
		could_not_initialise_input_manager = 0x0708,
		/// <summary>client library not initialized</summary>
		clientlibrary_not_initialised = 0x0709,
		/// <summary>server library not initialized</summary>
		serverlibrary_not_initialised = 0x070a,
		/// <summary>too many whisper targets</summary>
		whisper_too_many_targets = 0x070b,
		/// <summary>no whisper targets found</summary>
		whisper_no_targets = 0x070c,
		/// <summary>invalid file name</summary>
		file_invalid_name = 0x0800,
		/// <summary>invalid file permissions</summary>
		file_invalid_permissions = 0x0801,
		/// <summary>file already exists</summary>
		file_already_exists = 0x0802,
		/// <summary>file not found</summary>
		file_not_found = 0x0803,
		/// <summary>file input/output error</summary>
		file_io_error = 0x0804,
		/// <summary>invalid file transfer ID</summary>
		file_invalid_transfer_id = 0x0805,
		/// <summary>invalid file path</summary>
		file_invalid_path = 0x0806,
		/// <summary>no files available</summary>
		file_no_files_available = 0x0807,
		/// <summary>overwrite excludes resume</summary>
		file_overwrite_excludes_resume = 0x0808,
		/// <summary>invalid file size</summary>
		file_invalid_size = 0x0809,
		/// <summary>file already in use</summary>
		file_already_in_use = 0x080a,
		/// <summary>could not open file transfer connection</summary>
		file_could_not_open_connection = 0x080b,
		/// <summary>no space left on device (disk full?)</summary>
		file_no_space_left_on_device = 0x080c,
		/// <summary>file exceeds file system's maximum file size</summary>
		file_exceeds_file_system_maximum_size = 0x080d,
		/// <summary>file transfer connection timeout</summary>
		file_transfer_connection_timeout = 0x080e,
		/// <summary>lost file transfer connection</summary>
		file_connection_lost = 0x080f,
		/// <summary>file exceeds supplied file size</summary>
		file_exceeds_supplied_size = 0x0810,
		/// <summary>file transfer complete</summary>
		file_transfer_complete = 0x0811,
		/// <summary>file transfer canceled</summary>
		file_transfer_canceled = 0x0812,
		/// <summary>file transfer interrupted</summary>
		file_transfer_interrupted = 0x0813,
		/// <summary>file transfer server quota exceeded</summary>
		file_transfer_server_quota_exceeded = 0x0814,
		/// <summary>file transfer client quota exceeded</summary>
		file_transfer_client_quota_exceeded = 0x0815,
		/// <summary>file transfer reset</summary>
		file_transfer_reset = 0x0816,
		/// <summary>file transfer limit reached</summary>
		file_transfer_limit_reached = 0x0817,
		/// <summary>preprocessor disabled</summary>
		sound_preprocessor_disabled = 0x0900,
		/// <summary>internal preprocessor</summary>
		sound_internal_preprocessor = 0x0901,
		/// <summary>internal encoder</summary>
		sound_internal_encoder = 0x0902,
		/// <summary>internal playback</summary>
		sound_internal_playback = 0x0903,
		/// <summary>no capture device available</summary>
		sound_no_capture_device_available = 0x0904,
		/// <summary>no playback device available</summary>
		sound_no_playback_device_available = 0x0905,
		/// <summary>could not open capture device</summary>
		sound_could_not_open_capture_device = 0x0906,
		/// <summary>could not open playback device</summary>
		sound_could_not_open_playback_device = 0x0907,
		/// <summary>ServerConnectionHandler has a device registered</summary>
		sound_handler_has_device = 0x0908,
		/// <summary>invalid capture device</summary>
		sound_invalid_capture_device = 0x0909,
		/// <summary>invalid clayback device</summary>
		sound_invalid_playback_device = 0x090a,
		/// <summary>invalid wave file</summary>
		sound_invalid_wave = 0x090b,
		/// <summary>wave file type not supported</summary>
		sound_unsupported_wave = 0x090c,
		/// <summary>could not open wave file</summary>
		sound_open_wave = 0x090d,
		/// <summary>internal capture</summary>
		sound_internal_capture = 0x090e,
		/// <summary>device still in use</summary>
		sound_device_in_use = 0x090f,
		/// <summary>device already registerred</summary>
		sound_device_already_registerred = 0x0910,
		/// <summary>device not registered/known</summary>
		sound_unknown_device = 0x0911,
		/// <summary>unsupported frequency</summary>
		sound_unsupported_frequency = 0x0912,
		/// <summary>invalid channel count</summary>
		sound_invalid_channel_count = 0x0913,
		/// <summary>read error in wave</summary>
		sound_read_wave = 0x0914,
		/// <summary>sound need more data</summary>
		sound_need_more_data = 0x0915,
		/// <summary>sound device was busy</summary>
		sound_device_busy = 0x0916,
		/// <summary>there is no sound data for this period</summary>
		sound_no_data = 0x0917,
		/// <summary>Channelmask set bits count (speakers) is not the same as (count)</summary>
		sound_channel_mask_mismatch = 0x0918,
		/// <summary>invalid group ID</summary>
		permission_invalid_group_id = 0x0a00,
		/// <summary>duplicate entry</summary>
		permission_duplicate_entry = 0x0a01,
		/// <summary>invalid permission ID</summary>
		permission_invalid_perm_id = 0x0a02,
		/// <summary>empty result set</summary>
		permission_empty_result = 0x0a03,
		/// <summary>access to default group is forbidden</summary>
		permission_default_group_forbidden = 0x0a04,
		/// <summary>invalid size</summary>
		permission_invalid_size = 0x0a05,
		/// <summary>invalid value</summary>
		permission_invalid_value = 0x0a06,
		/// <summary>group is not empty</summary>
		permissions_group_not_empty = 0x0a07,
		/// <summary>insufficient client permissions</summary>
		permissions_client_insufficient = 0x0a08,
		/// <summary>insufficient group modify power</summary>
		permissions_insufficient_group_power = 0x0a09,
		/// <summary>insufficient permission modify power</summary>
		permissions_insufficient_permission_power = 0x0a0a,
		/// <summary>template group is currently used</summary>
		permission_template_group_is_used = 0x0a0b,
		/// <summary>permission error</summary>
		permissions = 0x0a0c,
		/// <summary>virtualserver limit reached</summary>
		accounting_virtualserver_limit_reached = 0x0b00,
		/// <summary>max slot limit reached</summary>
		accounting_slot_limit_reached = 0x0b01,
		/// <summary>license file not found</summary>
		accounting_license_file_not_found = 0x0b02,
		/// <summary>license date not ok</summary>
		accounting_license_date_not_ok = 0x0b03,
		/// <summary>unable to connect to accounting server</summary>
		accounting_unable_to_connect_to_server = 0x0b04,
		/// <summary>unknown accounting error</summary>
		accounting_unknown_error = 0x0b05,
		/// <summary>accounting server error</summary>
		accounting_server_error = 0x0b06,
		/// <summary>instance limit reached</summary>
		accounting_instance_limit_reached = 0x0b07,
		/// <summary>instance check error</summary>
		accounting_instance_check_error = 0x0b08,
		/// <summary>license file invalid</summary>
		accounting_license_file_invalid = 0x0b09,
		/// <summary>virtualserver is running elsewhere</summary>
		accounting_running_elsewhere = 0x0b0a,
		/// <summary>virtualserver running in same instance already</summary>
		accounting_instance_duplicated = 0x0b0b,
		/// <summary>virtualserver already started</summary>
		accounting_already_started = 0x0b0c,
		/// <summary>virtualserver not started</summary>
		accounting_not_started = 0x0b0d,
		/// <summary></summary>
		accounting_to_many_starts = 0x0b0e,
		/// <summary>invalid message id</summary>
		message_invalid_id = 0x0c00,
		/// <summary>invalid ban id</summary>
		ban_invalid_id = 0x0d00,
		/// <summary>connection failed, you are banned</summary>
		connect_failed_banned = 0x0d01,
		/// <summary>rename failed, new name is banned</summary>
		rename_failed_banned = 0x0d02,
		/// <summary>flood ban</summary>
		ban_flooding = 0x0d03,
		/// <summary>unable to initialize tts</summary>
		tts_unable_to_initialize = 0x0e00,
		/// <summary>invalid privilege key</summary>
		privilege_key_invalid = 0x0f00,
		/// <summary></summary>
		voip_pjsua = 0x1000,
		/// <summary></summary>
		voip_already_initialized = 0x1001,
		/// <summary></summary>
		voip_too_many_accounts = 0x1002,
		/// <summary></summary>
		voip_invalid_account = 0x1003,
		/// <summary></summary>
		voip_internal_error = 0x1004,
		/// <summary></summary>
		voip_invalid_connectionId = 0x1005,
		/// <summary></summary>
		voip_cannot_answer_initiated_call = 0x1006,
		/// <summary></summary>
		voip_not_initialized = 0x1007,
		/// <summary>invalid password</summary>
		provisioning_invalid_password = 0x1100,
		/// <summary>invalid request</summary>
		provisioning_invalid_request = 0x1101,
		/// <summary>no(more) slots available</summary>
		provisioning_no_slots_available = 0x1102,
		/// <summary>pool missing</summary>
		provisioning_pool_missing = 0x1103,
		/// <summary>pool unknown</summary>
		provisioning_pool_unknown = 0x1104,
		/// <summary>unknown ip location(perhaps LAN ip?)</summary>
		provisioning_unknown_ip_location = 0x1105,
		/// <summary>internal error(tried exceeded)</summary>
		provisioning_internal_tries_exceeded = 0x1106,
		/// <summary>too many slots requested</summary>
		provisioning_too_many_slots_requested = 0x1107,
		/// <summary>too many reserved</summary>
		provisioning_too_many_reserved = 0x1108,
		/// <summary>could not connect to provisioning server</summary>
		provisioning_could_not_connect = 0x1109,
		/// <summary>authentication server not connected</summary>
		provisioning_auth_server_not_connected = 0x1110,
		/// <summary>authentication data too large</summary>
		provisioning_auth_data_too_large = 0x1111,
		/// <summary>already initialized</summary>
		provisioning_already_initialized = 0x1112,
		/// <summary>not initialized</summary>
		provisioning_not_initialized = 0x1113,
		/// <summary>already connecting</summary>
		provisioning_connecting = 0x1114,
		/// <summary>already connected</summary>
		provisioning_already_connected = 0x1115,
		/// <summary></summary>
		provisioning_not_connected = 0x1116,
		/// <summary>io_error</summary>
		provisioning_io_error = 0x1117,
		/// <summary></summary>
		provisioning_invalid_timeout = 0x1118,
		/// <summary></summary>
		provisioning_ts3server_not_found = 0x1119,
		/// <summary>unknown permissionID</summary>
		provisioning_no_permission = 0x111A,
		/// <summary>For own custom errors</summary>
		custom_error = 0xFFFF,
		// ReSharper enable InconsistentNaming, UnusedMember.Global
	}
}