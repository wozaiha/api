﻿using MareSynchronos.API.Data;
using MareSynchronos.API.Data.Enum;

namespace MareSynchronos.API.Dto.Group;

public record GroupPairFullInfoDto(GroupData Group, UserData User, GroupUserInfo GroupPairStatusInfo, GroupUserPermissions GroupUserPermissions) : GroupPairDto(Group, User)
{
    public GroupUserInfo GroupPairStatusInfo { get; set; } = GroupPairStatusInfo;
    public GroupUserPermissions GroupUserPermissions { get; set; } = GroupUserPermissions;
}