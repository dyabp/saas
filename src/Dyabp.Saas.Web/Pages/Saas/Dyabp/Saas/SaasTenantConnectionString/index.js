$(function () {

    var l = abp.localization.getResource('Saas');

    var service = dyabp.saas.saasTenantConnectionString;
    var createModal = new abp.ModalManager(abp.appPath + 'Saas/Dyabp/Saas/SaasTenantConnectionString/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Saas/Dyabp/Saas/SaasTenantConnectionString/EditModal');

    var dataTable = $('#SaasTenantConnectionStringTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('Saas.SaasTenantConnectionString.Update'),
                                action: function (data) {
                                    editModal.open({
                                        tenantId: data.record.tenantId,
                                        name: data.record.name
                                    });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Saas.SaasTenantConnectionString.Delete'),
                                confirmMessage: function (data) {
                                    return l('SaasTenantConnectionStringDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete({
                                            tenantId: data.record.tenantId,
                                            name: data.record.name
                                        })
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('SaasTenantConnectionStringTenantId'),
                data: "tenantId"
            },
            {
                title: l('SaasTenantConnectionStringName'),
                data: "name"
            },
            {
                title: l('SaasTenantConnectionStringValue'),
                data: "value"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewSaasTenantConnectionStringButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
